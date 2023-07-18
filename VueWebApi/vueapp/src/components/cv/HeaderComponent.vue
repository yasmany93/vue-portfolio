<script setup>
defineProps(["profilePicture", "email", "phoneNumber", "name", "lastName"]);
</script>

<template>
  <div class="header">
    <div class="pic">
      <img :src="profilePicture" />
    </div>
    <div class="info">
      <div class="void"></div>
      <div class="elements">
        <input type="text" :value="name" placeholder="Enter your name" />
        <input
          type="text"
          :value="lastName"
          placeholder="Enter your last name"
        />
        <input type="email" :value="email" placeholder="Enter your email" />
        <input
          type="tel"
          :value="phoneNumber"
          placeholder="Enter your phone number"
        />
      </div>
    </div>
  </div>
</template>

<style scoped lang="scss">
.header {
  margin-top: 10vh;
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  height: 12em;

  & .pic {
    width: 50%;
    height: auto;

    & img {
      height: 50%;
      width: auto;
      border-radius: 50%;
      display: flex;

      &::after {
        content: "";
        flex: 1;
        margin: auto 1em;
        height: 0;
        border-top: solid red 1px;
        min-width: 2px;
      }
    }
  }

  & .info {
    width: 50%;
    display: flex;
    & .elements {
      display: block;
      width: 80%;

      & input {
        background-color: lightgray;
        border: none;
        border-radius: 5px;
        height: 35px;
        width: 90%;
        margin-bottom: 7px;
      }
    }

    & .void {
      width: 20%;
    }
  }
}
</style>
