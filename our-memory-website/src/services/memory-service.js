const axios = require("axios");
const memoryEndpoint = "memory/";

class MemoryService {
  constructor() {
    this.url = process.env.VUE_APP_API;
  }
  /**
   * Register a user.
   * @param {A entity Object} entity
   */
  async createMemory(entity) {
    const apiCall = await axios.post(memoryEndpoint, entity, {
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
  async getMemories() {
    const apiCall = await axios.get(memoryEndpoint, {
      headers: {
        "Access-Control-Allow-Origin": "*"
      }
    });
    return apiCall;
  }
}

export default MemoryService;
