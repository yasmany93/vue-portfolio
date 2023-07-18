import { createRouter, createWebHistory } from "vue-router";
import LoginView from "@/components/views/LoginView.vue";

const routes = [
  {
    path: "/login",
    name: "Login",
    component: LoginView,
  },
  {
    path: "/",
    name: "Home",
    component: () => import("../components/views/HomeView.vue"),
  },
  {
    path: "/about",
    name: "About",
    component: () => import("../components/views/AboutView.vue"),
  },
  {
    path: "/cvmaker",
    name: "CVMaker",
    component: () => import("../components/views/CVMakerView.vue"),
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
