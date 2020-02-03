import Vue from "vue";
import Vuex from "vuex";
import memory from "./modules/memory.js";
import user from "./modules/user.js";

Vue.use(Vuex);

const debug = process.env.NODE_ENV !== "production";

export default new Vuex.Store({
  modules: {
    memory,
    user
  },
  strict: debug
});
