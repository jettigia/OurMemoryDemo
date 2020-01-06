const axios = require('axios');
const apiUrl = 'https://localhost:44399/api/';
const registerPath = 'users/register'

function kebabCaseToCamel(str) {
      return str.replace( /(\-\w)/g, (matches) => matches[1].toUpperCase())
  }

class UserService {
  constructor(){
    this.url = apiUrl;
  }
  /**
   * Create and store a single entity's endpoints
   * @param {A entity Object} entity
   */
  register(entity) {
    const apiCall = axios.post(this.url + registerPath, entity)
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      });
    return apiCall;
  }
}

export default UserService