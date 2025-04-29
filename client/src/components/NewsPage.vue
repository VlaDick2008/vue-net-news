<script setup lang="ts">
import NewsItemCard from './ui/NewsItemCard.vue';

</script>

<template>
  <aside class="absolute left-0 w-full flex flex-col items-center justify-center">
    <h1 class="text-white text-6xl absolute z-50">News</h1>
    <img class="h-52 w-full object-cover " src="/news_header_bg.jpg" alt="header-image">
    <div class="absolute top-0 left-0 w-full h-full opacity-60 bg-black overlay"></div>
  </aside>
  <section>
    <div class="mt-72 flex flex-col gap-10">
      <NewsItemCard />
      <NewsItemCard />
      <NewsItemCard />
      <NewsItemCard />
      <NewsItemCard />
      <NewsItemCard />
    </div>
  </section>

</template>