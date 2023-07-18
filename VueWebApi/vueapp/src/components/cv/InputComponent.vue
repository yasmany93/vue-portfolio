<script setup>
import DynamicForm from "./DynamicForm.vue";

const cvProfile = {
  picture: null,
  education: [],
  workExperience: [],
  skills: [],
};

const educationForm = { small: 3, medium: 0, large: 0 };
const workExperienceForm = { small: 3, medium: 1, large: 0 };
</script>

<template>
  <div class="cvInput">
    <img :src="cvProfile.picture" />
    <label>Education</label>
    <DynamicForm :forms="educationForm" />

    <label>Work Experience</label>
    <DynamicForm :forms="workExperienceForm" />

    <label>Skills</label>
    <DynamicForm />
  </div>
</template>

<style scoped lang="scss">
@import "../../styles/variables.scss";
.cvInput {
  color: white;
  background-color: $sidebarBgColor;
  float: right;
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  padding: 0.5em;
  display: flex;
  flex-direction: column;
  width: 40vw;
  overflow: scroll;
  height: 100vh;
}
</style>
