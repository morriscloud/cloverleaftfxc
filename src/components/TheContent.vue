<template>
    <main>
        <div class="max-w-7xl mx-auto py-6 sm:px-6 lg:px-8 bg-white bg-opacity-60 my-3 dark:bg-black dark:bg-opacity-60 dark:text-white">
            <slot></slot>
        </div>
  </main>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  name: "TheContent"
});

</script>