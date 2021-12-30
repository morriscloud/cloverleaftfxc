<template>
  <Disclosure as="nav" class="bg-gray-800 nav-background" v-slot="{ open }">
    <div class="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
      <div class="flex items-center justify-between h-16">
        <div class="flex items-center">
          <div class="flex-shrink-0 text-white font-semibold">
            <router-link to="/">
              Cloverleaf Track
            </router-link>
          </div>
          <div class="hidden md:block">
            <div class="ml-10 flex items-baseline space-x-4">
              <router-link
                v-for="item in navigation"
                :key="item.name"
                :to="item.href"
                :class="[currentPageName === item.name ? 'bg-green-900 text-white border' : 'text-gray-300 hover:bg-green-900 hover:text-white focus:ring-2 focus:ring-green-600', 'px-3 py-2 rounded-md text-sm font-medium']"
                :aria-current="currentPageName === item.name ? 'page' : undefined">
                {{ item.name }}
              </router-link>
            </div>
          </div>
        </div>
        <button type="button" class="bg-gray-200 dark:bg-green-900 relative inline-flex flex-shrink-0 h-6 w-11 border-2 border-transparent rounded-full cursor-pointer transition-colors ease-in-out duration-200 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500" role="switch" aria-checked="false" @click="toggleDark()">
          <span :class="`${!isDark ? 'translate-x-5' : 'translate-x-0'} pointer-events-none relative inline-block h-5 w-5 rounded-full bg-white shadow transform ring-0 transition ease-in-out duration-200`">
            <span :class="`${!isDark ? 'opacity-0 ease-out duration-100' : 'opacity-100 ease-in duration-200'} absolute inset-0 h-full w-full flex items-center justify-center transition-opacity`" aria-hidden="true">
              <CarbonMoon class="h-4 w-4 text-green-900" />
            </span>
            <span :class="`${!isDark ? 'opacity-100 ease-in duration-200' : 'opacity-0 ease-out duration-100'} absolute inset-0 h-full w-full flex items-center justify-center transition-opacity`" aria-hidden="true">
              <CarbonSun class="h-4 w-4 text-indigo-600" />
            </span>
          </span>
        </button>
        <div class="-mr-2 flex md:hidden">
            <DisclosureButton class="bg-green-800 inline-flex items-center justify-center p-2 rounded-md border text-gray-400 hover:text-white hover:bg-green-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-offset-gray-800 focus:ring-white">
              <span class="sr-only">Open main menu</span>
              <MenuIcon v-if="!open" class="block h-6 w-6" aria-hidden="true" />
              <XIcon v-else class="block h-6 w-6" aria-hidden="true" />
            </DisclosureButton>
          </div>
      </div>
    </div>
    <DisclosurePanel class="md:hidden">
        <div class="px-2 pt-2 pb-3 space-y-1 sm:px-3">
          <DisclosureButton
            v-for="item in navigation"
            :key="item.name"
            as="a"
            :href="item.href"
            :class="[currentPageName === item.name ? 'bg-green-900 text-white border' : 'text-gray-300 hover:bg-green-900 hover:text-white focus:ring-2 focus:ring-green-600', 'block px-3 py-2 rounded-md text-base font-medium']"
            :aria-current="currentPageName === item.name ? 'page' : undefined">
            {{ item.name }}
          </DisclosureButton>
        </div>
      </DisclosurePanel>
  </Disclosure>
</template>

<script setup lang="ts">
import { Disclosure, DisclosureButton, DisclosurePanel } from '@headlessui/vue'
import { MenuIcon, XIcon } from '@heroicons/vue/outline'
import CarbonMoon from '@carbon/icons-vue/es/moon/16'
import CarbonSun from '@carbon/icons-vue/es/sun/16'
import { isDark, toggleDark } from '@/composables'
import { defineProps } from 'vue'

const navigation = [
  { name: 'Home', href: '/' },
  { name: 'Leaderboard', href: 'leaderboard' },
  { name: 'Seasons', href: 'seasons' },
  { name: 'Roster', href: 'roster' },
  { name: 'Meets', href: 'meets' },
];

defineProps({
  currentPageName: {
    required: true
  }
});
</script>