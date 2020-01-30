const axios = require("axios");
const textMemoryEndpoint = "textmemory/";

class MemoryService {
  constructor() {
    this.url = process.env.VUE_APP_API;
  }
  /**
   * Register a user.
   * @param {A entity Object} entity
   */
  async createTextMemory(entity) {
    const apiCall = await axios.post(textMemoryEndpoint, entity, {
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
