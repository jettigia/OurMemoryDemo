using AutoMapper;
using OurMemory.Entities;
using OurMemory.Models;
using OurMemoryDb;
using OurMemoryService.Interfaces;
using System;
using System.Threading.Tasks;
using WebApi.Helpers;

namespace OurMemoryService.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserViewModel> Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = await _userRepository.ReadEntityAsync(username);


            // check if username exists
            if (user == null)
                return null;

            // check if password is correct
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            // authentication successful
            var userViewModel = _mapper.Map<UserViewModel>(user);
            return userViewModel;
        }

        public async Task<UserViewModel> GetById(Guid id)
        {
            var entity = await _userRepository.ReadEntityAsync(id);
            var userViewModel = _mapper.Map<UserViewModel>(entity);
            return userViewModel;
        }

        public async Task<UserViewModel> Create(UserViewModel user, string password)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
                throw new AppException("Password is required");

            var checkUsernameUser = await _userRepository.ReadEntityAsync(user.Username);
            if (checkUsernameUser != null)
                throw new AppException("Username \"" + user.Username + "\" is already taken");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            var newUserEntity = _mapper.Map<UserEntity>(user);
            newUserEntity.PasswordHash = passwordHash;
            newUserEntity.PasswordSalt = passwordSalt;

            var dbUserEntity = await _userRepository.CreateEntityAsync(newUserEntity);
            var userViewModel = _mapper.Map<UserViewModel>(dbUserEntity);
            userViewModel.Password = string.Empty;
            userViewModel.Id = Guid.Empty;
            return userViewModel;
        }

        public async Task<UserViewModel> Update(UserViewModel userParam, string password = null)
        {
            var user = await _userRepository.ReadEntityAsync(userParam.Username);

            if (user == null)
                throw new AppException("User not found");

            // update username if it has changed
            if (!string.IsNullOrWhiteSpace(userParam.Username) && userParam.Username != user.Username)
            {
                // throw error if the new username is already taken
                if (_userRepository.ReadEntityAsync(user.Username) != null)
                    throw new AppException("Username " + userParam.Username + " is already taken");

                user.Username = userParam.Username;
            }

            // update user properties if provided
            if (!string.IsNullOrWhiteSpace(userParam.FirstName))
                user.FirstName = userParam.FirstName;

            if (!string.IsNullOrWhiteSpace(userParam.LastName))
                user.LastName = userParam.LastName;

            // update password if provided
            if (!string.IsNullOrWhiteSpace(password))
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            var userEntity = _mapper.Map<UserEntity>(user);
            var updatedUserEntity = _userRepository.UpdateEntityAsync(user);
            var userViewModel = _mapper.Map<UserViewModel>(updatedUserEntity);

            return userViewModel;
        }

        // private helper methods
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }
    }
}