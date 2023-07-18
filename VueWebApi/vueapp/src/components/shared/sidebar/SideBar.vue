<script setup>
import { toggleSideBar, sideBarWith, collapsed } from "./state";
import SideBarLink from "./SideBarLink.vue";
import ProfilePic from "./ProfilePic.vue";
</script>

<template>
  <div class="sidebar" :style="{ width: sideBarWith }">
    <ProfilePic />
    <SideBarLink to="/" icon="fas fa-home">Home</SideBarLink>
    <SideBarLink to="/cvmaker" icon="fa fa-file-pdf">CV Maker</SideBarLink>
    <SideBarLink to="/about" icon="fa fa-question-circle">About</SideBarLink>
    <span
      class="sidebar__collapse_icon"
      :class="collapsed ? 'sidebar__collapse_icon__rotate_180' : ''"
      @click="toggleSideBar"
    >
      <i class="fas fa-angle-double-left"></i>
    </span>
  </div>
</template>

<style scoped lang="scss">
@import "../../../styles/variables.scss";

.sidebar {
  color: white;
  background-color: $sidebarBgColor;
  float: left;
  position: fixed;
  top: 0;
  left: 0;
  bottom: 0;
  padding: 0.5em;
  display: flex;
  flex-direction: column;
  transition: 0.3s ease;

  &__collapse_icon {
    position: absolute;
    bottom: 0;
    padding: 0.75em;
    color: rgba(255, 255, 255, 0.7);
    transition: 0.2s linear;

    &__rotate_180 {
      transform: rotate(180deg);
      transition: 0.2s linear;
    }
  }
}
</style>
