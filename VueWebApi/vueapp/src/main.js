import { createApp } from "vue";
import App from "./App.vue";
import router from "@/router/index.js";
import "@fortawesome/fontawesome-free/js/all";

const app = createApp(App);
app.use(router);
app.mount("#app");
