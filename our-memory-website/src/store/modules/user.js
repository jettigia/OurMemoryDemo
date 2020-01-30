import UserService from "../../services/user-service.js";

const state = {
  user: null
};

// actions
const actions = {
  async login({ commit, state }, user) {
    const userService = new UserService();

    var result = await userService
      .authenticate(user)
      .then(response => {
        commit("setUser", response.data);
      })
      .catch(error => {
        commit("setLoginError", error.response.data.errors);
      });
  },
  async register({ commit, state }, user) {
    const userService = new UserService();

    var result = await userService
      .register(user)
      .then(response => {
        debugger;
        commit("setRegisterSuccess");
      })
      .catch(error => {
        debugger;
        commit("setRegisterFail", error.response.data.errors);
      });
    debugger;
  }
};

// mutations
const mutations = {
  setLoginError(state, user) {
    state.user.loginError = user;
  },
  setRegisterFail(state, user) {
    state.user.registerStatus = false;
    state.user.registerError = user;
  },
  setRegisterSuccess(state) {
    debugger;
    state.user = {};
    state.user.registerStatus = true;
    debugger;
  },
  setUser(state, user) {
    state.user = user;
  }
};

export default {
  namespaced: true,
  state,
  actions,
  mutations
};
