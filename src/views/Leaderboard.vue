<template>
  <div class="flex flex-col lg:flex-row not-prose">
    <div class="flex-auto mr-1">
      <h2 class="dark:text-gray-200 text-center text-3xl font-bold mb-2">
        Boys
      </h2>
      <table class="min-w-full divide-y divide-gray-200 dark:divide-gray-800 text-xs font-medium dark:text-white text-gray-500 tracking-wider">
        <thead class="bg-gray-50 dark:bg-black dark:bg-opacity-50 text-left">
          <tr>
            <th scope="col" class="px-6 py-3">
              Event
            </th>
            <th scope="col" class="px-6 py-3">
              Athlete
            </th>
            <th scope="col" class="px-6 py-3">
              Performance
            </th>
            <th scope="col" class="px-6 py-3">
              Date
            </th>
          </tr>
        </thead>
        <tbody class="text-left">
          <tr>
            <td colspan="4" class="px-6 py-3 text-center dark:bg-green-800 dark:bg-opacity-50 bg-gray-200 bg-opacity-50">
              Indoor
            </td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">60M</td>
            <td class="px-6 py-3">Zack Munchick</td>
            <td class="px-6 py-3">00:07.42</td>
            <td class="px-6 py-3">2017-02-04</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">200M</td>
            <td class="px-6 py-3">Blake Wilson</td>
            <td class="px-6 py-3">00:24.01</td>
            <td class="px-6 py-3">2021-02-20</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">400M</td>
            <td class="px-6 py-3">Andrew Hibler</td>
            <td class="px-6 py-3">00:55.88</td>
            <td class="px-6 py-3">2021-02-15</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">800M</td>
            <td class="px-6 py-3">Luke Malena</td>
            <td class="px-6 py-3">02:12.27</td>
            <td class="px-6 py-3">2021-01-30</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">1600M</td>
            <td class="px-6 py-3">Brett Gucker</td>
            <td class="px-6 py-3">05:03.98</td>
            <td class="px-6 py-3">2021-02-15</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">3200M</td>
            <td class="px-6 py-3">Max Gucker</td>
            <td class="px-6 py-3">09:38.48</td>
            <td class="px-6 py-3">2020-02-22</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">4x800M Relay</td>
            <td class="px-6 py-3">
              Andrew Hibler<br />
              Brett Gucker<br />
              Cole Yagersz<br />
              Nolan Freeland
            </td>
            <td class="px-6 py-3">09:38.48</td>
            <td class="px-6 py-3">2020-02-21</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">Long Jump</td>
            <td class="px-6 py-3">Adam Oren</td>
            <td class="px-6 py-3">16-09.00</td>
            <td class="px-6 py-3">2017-02-04</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">Shot Put</td>
            <td class="px-6 py-3">Brian Livingstone</td>
            <td class="px-6 py-3">45-10.00</td>
            <td class="px-6 py-3">2012-02-05</td>
          </tr>
          <tr>
            <td colspan="4" class="px-6 py-3 border-t-2 dark:border-black border-gray-400 text-center dark:bg-green-800 dark:bg-opacity-50 bg-gray-200 bg-opacity-50">
              Outdoor
            </td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">100M</td>
            <td class="px-6 py-3">Blake Wilson</td>
            <td class="px-6 py-3">00:10.83</td>
            <td class="px-6 py-3">2021-04-16</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">200M</td>
            <td class="px-6 py-3">B. Heffelfinger</td>
            <td class="px-6 py-3">00:21.60</td>
            <td class="px-6 py-3">1962-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">400M</td>
            <td class="px-6 py-3">Vince Beebe</td>
            <td class="px-6 py-3">00:49.66</td>
            <td class="px-6 py-3">2000-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">800M</td>
            <td class="px-6 py-3">Dave Freeland</td>
            <td class="px-6 py-3">01:52.40</td>
            <td class="px-6 py-3">1990-06-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">1600M</td>
            <td class="px-6 py-3">Willy Wiley</td>
            <td class="px-6 py-3">04:15.90</td>
            <td class="px-6 py-3">1987-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">3200M</td>
            <td class="px-6 py-3">D. Sturgeon</td>
            <td class="px-6 py-3">09:32.60</td>
            <td class="px-6 py-3">1986-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">110M Hurdles</td>
            <td class="px-6 py-3">D. Brinker</td>
            <td class="px-6 py-3">00:14.70</td>
            <td class="px-6 py-3">1980-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">300M Hurdles</td>
            <td class="px-6 py-3">Cory Beebe</td>
            <td class="px-6 py-3">00:38.51</td>
            <td class="px-6 py-3">2005-05-26</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">4x100M Relay</td>
            <td class="px-6 py-3">
              C. Hortsman<br />
              Chris Casteel<br />
              Russell Crall<br />
              T. Reed
            </td>
            <td class="px-6 py-3">00:43.80</td>
            <td class="px-6 py-3">2002-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">4x200M Relay</td>
            <td class="px-6 py-3">
              C. Hortsman<br />
              Chris Casteel<br />
              Russell Crall<br />
              T. Reed
            </td>
            <td class="px-6 py-3">01:31.70</td>
            <td class="px-6 py-3">2002-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">4x400M Relay</td>
            <td class="px-6 py-3">
              J. Stahl<br />
              M. Dilday<br />
              T. Nichols<br />
              Willy Wiley
            </td>
            <td class="px-6 py-3">03:25.00</td>
            <td class="px-6 py-3">1987-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">4x800M Relay</td>
            <td class="px-6 py-3">
              B. Garner<br />
              D. Wood<br />
              J. Smith<br />
              S. Kelly
            </td>
            <td class="px-6 py-3">07:57.90</td>
            <td class="px-6 py-3">1986-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">4x1600M Relay</td>
            <td class="px-6 py-3">
              D. Sturgeon<br />
              M. Garbaccio<br />
              T. Neura<br />
              Willy Wiley
            </td>
            <td class="px-6 py-3">18:22.30</td>
            <td class="px-6 py-3">1986-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">Sprint Medley</td>
            <td class="px-6 py-3">
              Andrew Hibler<br />
              Blake Wilson<br />
              Luke Yuravak<br />
              Michael Williams
            </td>
            <td class="px-6 py-3">01:38.25</td>
            <td class="px-6 py-3">2021-04-10</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-10 bg-gray-200 bg-opacity-5">
            <td class="px-6 py-3">Distance Medley</td>
            <td class="px-6 py-3">
              B. Hahn<br />
              M. Lang<br />
              S. Murphy<br />
              S. Yatson
            </td>
            <td class="px-6 py-3">10:36.70</td>
            <td class="px-6 py-3">1982-05-01</td>
          </tr>
          <tr class="dark:bg-green-900 dark:bg-opacity-25 bg-gray-200 bg-opacity-20">
            <td class="px-6 py-3">Sprint Medley</td>
            <td class="px-6 py-3">
              Andrew Hibler<br />
              Blake Wilson<br />
              Luke Yuravak<br />
              Michael Williams
            </td>
            <td class="px-6 py-3">01:38.25</td>
            <td class="px-6 py-3">2021-04-10</td>
          </tr>
        </tbody>
      </table>
    </div>
    <div class="flex-auto mr-1">
      <h2 class="dark:text-gray-200 text-center text-3xl font-bold mb-2">
        Girls
      </h2>
      <table class="min-w-full divide-y divide-gray-200 dark:divide-gray-800 text-xs font-medium dark:text-white text-gray-500 uppercase tracking-wider">
        <thead class="bg-gray-50 dark:bg-black dark:bg-opacity-50 text-left">
          <tr>
            <th scope="col" class="px-6 py-3">
              Event
            </th>
            <th scope="col" class="px-6 py-3">
              Athlete
            </th>
            <th scope="col" class="px-6 py-3">
              Performance
            </th>
            <th scope="col" class="px-6 py-3">
              Date
            </th>
          </tr>
        </thead>
        <tbody class="text-left">
          <tr>
            <td colspan="4" class="px-6 py-3 text-center dark:bg-green-800 dark:bg-opacity-50 bg-gray-200 bg-opacity-50">
              Indoor
            </td>
          </tr>
          <tr>
            <td class="px-6 py-3">60M</td>
            <td class="px-6 py-3">Zack Munchick</td>
            <td class="px-6 py-3">00:07.42</td>
            <td class="px-6 py-3">2017-02-04</td>
          </tr>
          <tr>
            <td class="px-6 py-3">200M</td>
            <td class="px-6 py-3">Blake Wilson</td>
            <td class="px-6 py-3">00:24.01</td>
            <td class="px-6 py-3">2021-02-20</td>
          </tr>
          <tr>
            <td class="px-6 py-3">400M</td>
            <td class="px-6 py-3">Andrew Hibler</td>
            <td class="px-6 py-3">00:55.88</td>
            <td class="px-6 py-3">2021-02-15</td>
          </tr>
          <tr>
            <td class="px-6 py-3">800M</td>
            <td class="px-6 py-3">Luke Malena</td>
            <td class="px-6 py-3">02:12.27</td>
            <td class="px-6 py-3">2021-01-30</td>
          </tr>
          <tr>
            <td class="px-6 py-3">1600M</td>
            <td class="px-6 py-3">Brett Gucker</td>
            <td class="px-6 py-3">05:03.98</td>
            <td class="px-6 py-3">2021-02-15</td>
          </tr>
          <tr>
            <td class="px-6 py-3">3200M</td>
            <td class="px-6 py-3">Max Gucker</td>
            <td class="px-6 py-3">09:38.48</td>
            <td class="px-6 py-3">2020-02-22</td>
          </tr>
          <tr>
            <td class="px-6 py-3">4x800M Relay</td>
            <td class="px-6 py-3">
              Andrew Hibler<br />
              Brett Gucker<br />
              Cole Yagersz<br />
              Nolan Freeland
            </td>
            <td class="px-6 py-3">09:38.48</td>
            <td class="px-6 py-3">2020-02-21</td>
          </tr>
          <tr>
            <td class="px-6 py-3">Long Jump</td>
            <td class="px-6 py-3">Adam Oren</td>
            <td class="px-6 py-3">16-09.00</td>
            <td class="px-6 py-3">2017-02-04</td>
          </tr>
          <tr>
            <td class="px-6 py-3">Shot Put</td>
            <td class="px-6 py-3">Brian Livingstone</td>
            <td class="px-6 py-3">45-10.00</td>
            <td class="px-6 py-3">2012-02-05</td>
          </tr>
          <tr>
            <td colspan="4" class="px-6 py-3 text-center dark:bg-green-800 dark:bg-opacity-50 bg-gray-200 bg-opacity-50">
              Outdoor
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script setup lang="ts">
</script>
