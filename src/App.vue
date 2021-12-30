<template>
  <TheTopNav :currentPageName="$route.name" />
  <TheHeader>{{ $route.name }}</TheHeader>
  <TheContent>
    <router-view></router-view>
  </TheContent>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import TheTopNav from './components/TheTopNav.vue';
import TheHeader from './components/TheHeader.vue';
import TheContent from './components/TheContent.vue';

export default defineComponent({
  name: "App",
  components: {
    TheTopNav,
    TheHeader,
    TheContent
  }
});
</script>
