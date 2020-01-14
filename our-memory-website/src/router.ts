import Vue from "vue";
import Router from "vue-router";
import Home from "./views/Home.vue";
import Register from "./views/Registration.vue";
import RegisterSuccess from "@/views/RegistrationSuccess.vue";
import RegisterUnsuccess from "@/views/RegistrationUnSuccess.vue";

Vue.use(Router);

export default new Router({
  mode: "history",
  base: process.env.BASE_URL,
  routes: [
    {
      path: "/",
      name: "home",
      component: Home
    },
    {
      path: "/about",
      name: "about",
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () =>
        import(/* webpackChunkName: "about" */ "./views/About.vue")
    },
    {
      path: "/registration",
      name: "registration",
      component: Register
    },
    {
      path: "/registration-success",
      name: "registration-success",
      component: RegisterSuccess
    },
    {
      path: "/registration-unsuccess",
      name: "registration-unsuccess",
      component: RegisterUnsuccess
    },
    {
      path: "*",
      name: "default",
      component: Home
    }
  ]
});
