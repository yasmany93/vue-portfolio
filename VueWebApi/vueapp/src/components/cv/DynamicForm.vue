<script setup>
import { computed, ref, onBeforeMount } from "vue";
const props = defineProps({
  placeHolders: {
    type: Object,
    default: null,
  },
  forms: {
    type: Object,
    default: () => ({ small: 0, medium: 0, large: 0 }),
  },
  types: {
    type: String,
    default: null,
  },
  section: {
    type: Boolean,
    default: false,
  },
});

const inputStyleClass = (index) => {
  return index < props.forms.small
    ? "smallSize"
    : index < props.forms.small + props.forms.medium
    ? "mediumSize"
    : index < props.forms.small + props.forms.medium + props.forms.large
    ? "largeSize"
    : null;
};

const updateInfo = () => {
  console.log("Updated");
};

const blockElements = ref([]);

const dynamicFormInfo = ref([]);

const blockGenerated = () => {
  // Build an array and fill it with empty strings
  const inputFormBlock = Array(totalFroms.value).fill("");
  dynamicFormInfo.value.push(inputFormBlock);
};

onBeforeMount(() => {
  blockGenerated();
});

const addFormBlock = () => {
  blockGenerated();
};

const deleteFormBlock = () => {};

const totalFroms = computed(
  () => props.forms.small + props.forms.medium + props.forms.large
);
</script>

<template>
  <div class="formStyling">
    <div
      v-for="(block, blockIndex) in dynamicFormInfo"
      :key="blockIndex"
      ref="blockElements"
    >
      <button @click="deleteFormBlock(blockIndex)">
        <i class="fa fa-minus"></i>
      </button>
      <div v-for="(value, formIndex) in block" :key="formIndex">
        <input
          :class="inputStyleClass(formIndex)"
          :placeholder="props?.placeHolders && props?.placeHolders[formIndex]"
          :type="props?.types && props.types[formIndex]"
          @change="updateInfo"
          :value="value"
        />
      </div>
    </div>

    <button @click="addFormBlock">
      <i class="fa fa-plus"></i>
    </button>
  </div>
</template>

<style scoped lang="scss">
@import "../../styles/variables.scss";

.formStyling {
  width: 100%;

  & .smallSize {
    height: $smallForm;
  }

  & .mediumSize {
    height: $mediumForm;
  }

  & .largeSize {
    height: $largeForm;
  }
}
</style>
