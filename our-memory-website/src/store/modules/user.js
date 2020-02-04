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
        commit("setUser", response);
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
        commit("setRegisterSuccess");
      })
      .catch(error => {
        commit("setRegisterFail", error.response.data.errors);
      });
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
    state.user = {};
    state.user.registerStatus = true;
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
