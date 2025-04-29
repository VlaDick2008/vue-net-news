<script lang="ts" setup>
defineProps<{
  name: string,
  imageUrl: string,
  url: string,
  description: string,
  publishedAt: string
}>()

function formatDate(dateStr: string) {
  return new Date(dateStr).toLocaleDateString('ru-RU');
}
</script>

<template>
  <a :href="url" target="_blank" class="border flex gap-4">
    <img class="w-[370px] h-[250px] object-cover" :src="imageUrl" alt="news_image">
    <div class="p-4 flex flex-col gap-3 h-[250px] overflow-hidden relative flex-1">
      <div class="flex gap-5 items-center">
        <span class="text-red-600">{{ formatDate(publishedAt) }}</span>
        <span class="bg-red-600 text-white text-sm px-2 leading-6">News</span>
      </div>
      <h2 class="text-3xl">{{ name }}</h2>
      <p class="text-lg">{{ description }}
      </p>
      <div class="pointer-events-none absolute bottom-0 left-0 w-full h-24 bg-gradient-to-t from-white to-transparent">
      </div>
    </div>
  </a>
</template>