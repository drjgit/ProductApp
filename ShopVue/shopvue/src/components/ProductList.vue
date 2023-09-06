<template>
    <h2>ProductList</h2>
</template>

<script setup>
import pinia from "@/stores"
import useProductList from "@/stores/useProductList"
import { onMounted } from "vue"

const ProductList = useProductList(pinia)

onMounted(async () => {
    await ProductList.getAllProduct()
})
</script>

<style> 

</style>