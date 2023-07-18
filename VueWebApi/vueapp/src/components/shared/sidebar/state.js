import { ref, computed } from "vue";

export const collapsed = ref(false);
export const toggleSideBar = () => {
  collapsed.value = !collapsed.value;
};

export const SIDEBAR_WITH = 180;
export const SIDEBAR_WITH_COLLAPSED = 38;
export const sideBarWith = computed(
  () => `${collapsed.value ? SIDEBAR_WITH_COLLAPSED : SIDEBAR_WITH}px`
);
