const axios = require("axios");
const usersEndpoint = "user/";
const registerPath = `${usersEndpoint}register`;
const authenticatePath = `${usersEndpoint}authenticate`;
const versionPath = `${usersEndpoint}version`;

class UserService {
  constructor() {
    this.url = process.env.VUE_APP_API;
  }
  /**
   * Register a user.
   * @param {A entity Object} entity
   */
  async register(entity) {
    const apiCall = await axios.post(this.url + registerPath, entity, {
      headers: {
        "Access-Control-Allow-Origin": "*",
        "Access-Control-Allow-Methods": "GET, POST"
      }
    });
    return apiCall;
  }

  /**
   * Register a user.
   * @param {A entity Object} entity
   */
  async getVersion(entity) {
    const apiCall = await axios.get(this.url + versionPath, entity, {
      headers: {
        "Access-Control-Allow-Origin": "*"
      }
    });
    return apiCall;
  }

  async getVersionPost(entity) {
    const apiCall = await axios.post(this.url + versionPath, entity, {
      headers: {
        "Access-Control-Allow-Origin": "*"
      }
    });
    return apiCall;
  }

  /**
   * User Login.
   * @param {A entity Object} entity
   */
  async authenticate(entity) {
    const apiCall = await axios.post(this.url + authenticatePath, entity, {
      headers: {
        "Access-Control-Allow-Origin": "*"
      }
    });
    return apiCall;
  }
}

export default UserService;
