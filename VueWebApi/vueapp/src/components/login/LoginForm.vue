<script setup>
const props = defineProps(["loginInfo"]);
</script>

<template>
  <div>
    <input
      type="text"
      placeholder="Write a name here"
      :value="props.loginInfo.name"
    />
    <input
      type="email"
      placeholder="Write a email here"
      :value="props.loginInfo.email"
    />
    <button>Login</button>
  </div>
</template>

<style scoped></style>
