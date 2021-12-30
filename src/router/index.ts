import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router'
import Home from '../views/Home.vue'
import Leaderboard from '../views/Leaderboard.vue'
import Meets from '../views/Meets.vue'
import Roster from '../views/Roster.vue'
import Seasons from '../views/Seasons.vue'

const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/leaderboard',
    name: 'Leaderboard',
    component: Leaderboard
  },
  {
    path: '/seasons',
    name: 'Seasons',
    component: Seasons
  },
  {
    path: '/roster',
    name: 'Roster',
    component: Roster
  },
  {
    path: '/meets',
    name: 'Meets',
    component: Meets
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
