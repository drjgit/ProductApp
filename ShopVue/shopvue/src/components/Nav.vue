<template>
    <el-menu class="el-menu-demo" mode="horizontal" :ellipsis="false" @select="FindProductByCategory">
        <div class="flex-grow" />
        <el-menu-item index="feature">首页</el-menu-item>
        <div class="flex-grow" />

        <template v-for="category in Categories.Categories" :key="category.id">
            <el-menu-item :index="category.url">{{category.name}}</el-menu-item>
            <div class="flex-grow" />
        </template>
    </el-menu>
</template>

<script setup>
import { onMounted } from "vue"
import { useRouter } from "vue-router"
import pinia from "@/stores"
import useCategory from "@/stores/useCategory"
import useProductList from "@/stores/useProductList"


const Categories = useCategory(pinia)
const ProductList = useProductList(pinia)

const router = useRouter();

onMounted(async () => {
    await Categories.getCategories();
})

async function FindProductByCategory(url) {
    if (url !== "feature") {
        await ProductList.getProductByCategory(url);
    }

    router.push({
        path: `/product/${url}`
    })
}
</script>

<style scoped>
.flex-grow{
    flex-grow: 1;
}
</style>