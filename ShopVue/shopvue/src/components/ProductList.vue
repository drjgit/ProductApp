<template>
    <h2>ProductList</h2>
</template>

<script>
import useProductList from '@/stores/useProductList';
import { onMounted } from 'vue';

const varProductList = useProductList();

onMounted(async () => {
    await varProductList.getAllProduct();
})
</script>

<style> 

</style>