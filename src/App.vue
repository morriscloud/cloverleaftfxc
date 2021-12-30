<template>
  <TheTopNav :currentPageName="$route.name" />
  <TheHeader>{{ $route.name }}</TheHeader>
  <TheContent>
    <router-view></router-view>
  </TheContent>
  <TheFooter></TheFooter>
</template>

<script setup lang="ts">
import TheTopNav from './components/TheTopNav.vue';
import TheHeader from './components/TheHeader.vue';
import TheContent from './components/TheContent.vue';
import TheFooter from './components/TheFooter.vue';
</script>
