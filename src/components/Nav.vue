<template>
  <Disclosure as="nav" class="bg-gray-800 navBackground" v-slot="{ open }">
    <div class="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
      <div class="flex items-center justify-between h-16">
        <div class="flex items-center">
          <div class="flex-shrink-0 text-white">
            Cloverleaf Track
          </div>
          <div class="hidden md:block">
            <div class="ml-10 flex items-baseline space-x-4">
              <router-link v-for="item in navigation" :key="item.name" :to="item.href" :class="[item.current ? 'bg-gray-900 text-white' : 'text-gray-300 hover:bg-gray-700 hover:text-white', 'px-3 py-2 rounded-md text-sm font-medium']" :aria-current="item.current ? 'page' : undefined">{{ item.name }}</router-link>
            </div>
          </div>
        </div>
        <div class="-mr-2 flex md:hidden">
            <DisclosureButton class="bg-gray-800 inline-flex items-center justify-center p-2 rounded-md text-gray-400 hover:text-white hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-offset-gray-800 focus:ring-white">
              <span class="sr-only">Open main menu</span>
              <MenuIcon v-if="!open" class="block h-6 w-6" aria-hidden="true" />
              <XIcon v-else class="block h-6 w-6" aria-hidden="true" />
            </DisclosureButton>
          </div>
      </div>
    </div>
  </Disclosure>
</template>

<script lang="ts">
import { Disclosure, DisclosureButton } from '@headlessui/vue'
import { MenuIcon, XIcon } from '@heroicons/vue/outline'
import { defineComponent } from "vue";

const navigation = [
  { name: "Home", href: "/", current: true },
  { name: "Leaderboard", href: "leaderboard", current: false },
  { name: "Seasons", href: "seasons", current: false },
  { name: "Roster", href: "roster", current: false },
  { name: "Meets", href: "meetgs", current: false },
]

export default defineComponent({
  name: "Nav",
  components: {
    Disclosure,
    DisclosureButton,
    MenuIcon,
    XIcon
  },
  setup() {
    return {
      navigation
    }
  }
});

</script>