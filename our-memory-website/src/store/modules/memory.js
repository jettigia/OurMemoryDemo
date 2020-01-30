import MemoryService from "../../services/memory-service.js.js";

const state = {
  getMemoryError: "",
  memories: [],
  memoryUploadStatus: ""
};

// actions
const actions = {
  async uploadMemory({ commit, state }, memory) {
    const memoryService = new MemoryService();

    var result = await userService
      .uploadMemory(memory)
      .then(response => {
        commit("setUploadStatus", response.data);
      })
      .catch(error => {
        commit("setUploadStatus", error.response.data.errors);
      });
  },
  async getMemories({ commit, state }) {
    const memoryService = new MemoryService();

    var result = await memoryService
      .getMemories(user)
      .then(response => {
        debugger;
        commit("setMemories");
      })
      .catch(error => {
        debugger;
        commit("setMemoryFail", error.response.data.errors);
      });
    debugger;
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
    state.memoryUploadStatus = status;
  }
};

export default {
  namespaced: true,
  state,
  actions,
  mutations
};
