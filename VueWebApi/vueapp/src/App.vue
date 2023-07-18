<script setup>
import SideBar from "./components/shared/sidebar/SideBar.vue";
import { sideBarWith } from "./components/shared/sidebar/state.js";
</script>

<template>
  <div>
    <SideBar />
    <div
      :style="{ 'margin-left': sideBarWith }"
      class="container container__transition"
    >
      <RouterView />
    </div>
  </div>
</template>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>

<style scoped lang="scss">
.container {
  padding: 5vh 5vw;
  box-sizing: border-box;

  &__transition {
    transition: 0.2s linear;
  }
}
</style>
