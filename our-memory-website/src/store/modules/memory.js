import MemoryService from "../../services/memory-service.js.js";

const state = {
  getMemoryError: "",
  memories: [],
  memoryUploadSuccess: false,
  memoryUploadStatus: ""
};

// actions
const actions = {
  async createTextMemory({ commit }, textMemory) {
    const memoryService = new MemoryService();

    var result = await userService
      .createTextMemory(memory)
      .then(response => {
        commit("setUploadSuccess");
      })
      .catch(error => {
        commit("setUploadFailure", error.response.data.errors);
      });
  },
  async uploadMemory({ commit, state }, memory) {
    const memoryService = new MemoryService();

    var result = await userService
      .uploadMemory(memory)
      .then(response => {
        commit("setUploadSuccess");
      })
      .catch(error => {
        commit("setUploadFailure", error.response.data.errors);
      });
  },
  async getMemories({ commit, state }) {
    const memoryService = new MemoryService();

    var result = await memoryService
      .getMemories(user)
      .then(response => {
        commit("setMemories");
      })
      .catch(error => {
        commit("setMemoryFail", error.response.data.errors);
      });
  }
};

// mutations
const mutations = {
  setMemories(state, memories) {
    state.memories = memories;
  },
  setMemoryFail(state, errors) {
    state.getMemoryError = errors;
  },
  setUploadStatus(state, status) {
    state.get = status;
  },
  setUploadFailure(state, error) {
    state.memoryUploadStatus = error;
    state.memoryUploadSuccess = false;
  },
  setUploadSuccess(state) {
    state.memoryUploadSuccess = true;
  }
};

export default {
  namespaced: true,
  state,
  actions,
  mutations
};
