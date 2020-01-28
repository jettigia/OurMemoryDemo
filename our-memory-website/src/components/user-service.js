const axios = require('axios');
// const apiUrl = 'https://localhost:44399/api/';
const apiUrl = "http://finitech-001-site1.gtempurl.com/api/";
const registerPath = `${usersEndpoint}register`;
const authenticatePath = `${usersEndpoint}authenticate`;
const versionPath = `${usersEndpoint}version`;

function kebabCaseToCamel(str) {
      return str.replace( /(\-\w)/g, (matches) => matches[1].toUpperCase())
  }

class UserService {
  constructor(){
    this.url = apiUrl;
  }
  /**
   * Register a user.
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

    /**
   * Register a user.
   * @param {A entity Object} entity
   */
  getVersion(entity) {
    const apiCall = axios.get(this.url + versionPath, entity, {
      headers: {
        'Access-Control-Allow-Origin': '*'
      }})
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      });
    return apiCall;
  }

  /**
   * User Login.
   * @param {A entity Object} entity
   */
  authenticate(entity) {
    const apiCall = axios.post(this.url + authenticatePath, entity)
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