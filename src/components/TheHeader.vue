<template>
    <header class="bg-white shadow-lg dark:bg-black">
      <div class="max-w-7xl mx-auto py-6 px-4 sm:px-6 lg:px-8">
        <h1 class="text-3xl font-bold text-gray-900 dark:text-white">
          <slot></slot>
        </h1>
      </div>
    </header>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  name: "TheHeader"
});

</script>