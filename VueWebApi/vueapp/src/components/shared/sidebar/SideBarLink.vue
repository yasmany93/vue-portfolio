<script setup>
import { computed } from "vue";
import { useRoute } from "vue-router";
import { collapsed } from "./state";

const props = defineProps(["to", "icon"]);
const route = useRoute();
const isActive = computed(() => route.path === props.to);

defineExpose({ isActive, collapsed });
</script>

<template>
  <RouterLink :to="to" class="link" :class="isActive ? 'link__active' : ''">
    <i class="link__icon" :class="icon" aria-hidden="true"></i>
    <Transition name="fade">
      <span v-if="!collapsed">
        <slot></slot>
      </span>
    </Transition>
  </RouterLink>
</template>

<style scoped lang="scss">
@import "../../../styles/variables.scss";

.fade-enter-active,
.fade-leave-active {
  transition: opacity 0.1s;
}

.fade-enter,
.fade-leave-to {
  opacity: 0;
}

.link {
  display: flex;
  align-items: center;
  cursor: pointer;
  position: relative;
  font-weight: 400;
  margin: o.1em 0;
  border-radius: 0.4em;
  height: 1.5em;
  color: white;
  text-align: none;
  text-decoration: none;

  &:hover {
    background-color: $sidebarItemHover;
  }

  &__active {
    background-color: $sidebarItemActive;
  }

  &__icon {
    flex-shrink: 0;
    width: 25px;
    margin-right: 10px;
  }
}
</style>
