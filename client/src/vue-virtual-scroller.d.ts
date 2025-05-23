// Type definitions for vue-virtual-scroller
// Project: https://github.com/Akryum/vue-virtual-scroller/
declare module "vue-virtual-scroller" {
	import type Vue from "vue";
	import type { ComponentOptions, PluginObject, Component } from "vue";
	interface PluginOptions {
		installComponents?: boolean;
		componentsPrefix?: string;
	}

	const plugin: PluginObject<PluginOptions> & { version: string };

	export const RecycleScroller: Component<any, any, any, any>;
	export const DynamicScroller: Component<any, any, any, any>;
	export const DynamicScrollerItem: Component<any, any, any, any>;

	export function IdState(options?: {
		idProp?: (vm: any) => any;
	}): ComponentOptions<Vue> | typeof Vue;

	export default plugin;
}
