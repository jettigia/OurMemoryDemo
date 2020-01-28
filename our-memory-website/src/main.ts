import Vue from "vue";
import Vuex from "vuex";
import store from "./store/index.js";
import App from "./App.vue";
import router from "./router";
import "./registerServiceWorker";
import BootstrapVue from "bootstrap-vue";
import "bootstrap/dist/css/bootstrap.css";
import "bootstrap-vue/dist/bootstrap-vue.css";

Vue.config.productionTip = false;
Vue.use(BootstrapVue);
Vue.use(Vuex);

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount("#app");
