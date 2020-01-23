import Vue from "vue";
import Router from "vue-router";
import Home from "./views/Home.vue";
import Register from "./views/Registration.vue";
import RegisterSuccess from "@/views/RegistrationSuccess.vue";
import RegisterUnSuccess from "@/views/RegistrationUnSuccess.vue";
import Dashboard from "./views/Dashboard.vue";
import NewTextMemory from "./views/NewTextMemory.vue";
import NewPhotoMemory from "./views/NewPhotoMemory.vue";
import NewVideoMemory from "./views/NewVideoMemory.vue";
import MemoryCreateSuccess from "./views/MemoryCreateSuccess.vue";

Vue.use(Router);

export default new Router({
  mode: "history",
  base: process.env.BASE_URL,
  // TODO: All routes here and in the application should use a constant.
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
      path: "/registrationSuccess",
      name: "registrationSuccess",
      component: RegisterSuccess
    },
    {
      path: "/registrationUnSuccess",
      name: "registrationUnsuccess",
      component: RegisterUnSuccess
    },
    {
      path: "/dashboard",
      name: "dashboard",
      component: Dashboard
    },
    {
      path: "*",
      name: "default",
      component: Home
    },
    {
      path: "/newTextMemory",
      name: "newTextMemory",
      component: NewTextMemory
    },
    {
      path: "/newPhotoMemory",
      name: "newPhotoMemory",
      component: NewPhotoMemory
    },
    {
      path: "/newVideoMemory",
      name: "newVideoMemory",
      component: NewVideoMemory
    },
    {
      path: "/memoryCreateSuccess",
      name: "memoryCreateSuccess",
      component: MemoryCreateSuccess
    }
  ]
});
