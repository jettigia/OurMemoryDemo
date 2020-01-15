const axios = require('axios');
const apiUrl = 'http://finitech-001-site1.gtempurl.com/api/';
const usersEndpoint = 'users/';
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
  async register(entity) {
    const apiCall = await axios.post(this.url + registerPath, entity);
    return apiCall;
  }

    /**
   * Register a user.
   * @param {A entity Object} entity
   */
  async getVersion(entity) {
    const apiCall = await axios.get(this.url + versionPath, entity, {
      headers: {
        'Access-Control-Allow-Origin': '*'
      }});
    return apiCall;
  }

  /**
   * User Login.
   * @param {A entity Object} entity
   */
  async authenticate(entity) {
    const apiCall = await axios.post(this.url + authenticatePath, entity);
    return apiCall;
  }
}

export default UserService