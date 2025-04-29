import { defineStore } from "pinia";
import axios from "axios";

export interface NewsItem {
	id: number;
	title: string;
	summary: string;
	url: string;
	publishedAt: string;
}

export const useNewsStore = defineStore("news", {
	state: () => ({
		items: [] as NewsItem[],
		loading: false,
		error: "" as string | null,
	}),
	actions: {
		async fetchNews(query?: string) {
			this.loading = true;
			this.error = null;

			try {
				const res = await axios.get("http://localhost:5007/api/news", {
					params: { q: query },
				});
				this.items = res.data;
			} catch (err: unknown) {
				if (err instanceof Error) {
					this.error = err.message;
				} else {
					this.error = "Неизвестная ошибка";
				}
			} finally {
				this.loading = false;
			}
		},
	},
});
