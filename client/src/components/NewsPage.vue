<script setup lang="ts">
import NewsItemCard from './ui/NewsItemCard.vue';
import { RecycleScroller } from 'vue-virtual-scroller';
import { ref, onMounted } from 'vue';
import { useNewsStore } from '@/stores/news';

const store = useNewsStore();
const search = ref('')

onMounted(() => {
  store.fetchNews();
})

function onSearch() {
  store.fetchNews(search.value)
}
</script>

<template>
  <aside class="absolute left-0 w-full flex flex-col items-center justify-center">
    <h1 class="text-white text-6xl absolute z-50">News</h1>
    <img class="h-52 w-full object-cover " src="/news_header_bg.jpg" alt="header-image">
    <div class="absolute top-0 left-0 w-full h-full opacity-60 bg-black overlay"></div>
  </aside>
  <section class="mt-64 flex flex-col gap-10">
    <label class="flex flex-col gap-2 text-3xl font-bold">News search <input type="text" v-model="search"
        @input="onSearch" placeholder="Enter title or desctiption..."
        class="border p-2 text-lg font-normal placeholder:text-gray-600">
      <div v-if="store.loading" class="text-center">Загрузка...</div>
      <div v-if="store.error" class="text-red-500">Ошибка: {{ store.error }}</div>
    </label>
    <RecycleScroller :items="store.items" :item-size="300" class="news-list" key-field="id" v-slot="{ item }">
      <NewsItemCard :name="item.name" :description="item.description" :imageUrl="item.imageUrl" :url="item.url"
        :published-at="item.publishedAt" />
    </RecycleScroller>

  </section>

</template>