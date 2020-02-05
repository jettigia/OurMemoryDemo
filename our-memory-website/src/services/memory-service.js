const axios = require("axios");
const memoryEndpoint = process.env.VUE_APP_API + "memory/";

class MemoryService {
  constructor() {
    axios.baseUrl = process.env.VUE_APP_API;
    axios.defaults.withCredentials = true;
  }
  /**
   * Register a user.
   * @param {A entity Object} entity
   */
  async createMemory(entity) {
    const apiCall = await axios.post(memoryEndpoint, entity, {
      headers: {
        "Access-Control-Allow-Origin": "http://localhost:8080/"
      }
    });
    return apiCall;
  }

  /**
   * Register a user.
   * @param {A entity Object} entity
   */
  async getMemories() {
    const apiCall = await axios.get(memoryEndpoint, {
      headers: {
        "Access-Control-Allow-Origin": "http://localhost:8080/"
      }
    });
    return apiCall;
  }
}

export default MemoryService;
