<template>
    <h2>商品列表</h2>

    <div class="container">
        <template v-for="product in ProductList.Products" :key="product.id">  
            <div class="product">   
                <a @click="detail(product.id)">
                    <img class="media-img" :src="product.imageUrl">
                </a>

                <div class="media-body">
                    <a @click="detail(product.id)">
                        <h3>{{ product.titile }}</h3>
                    </a>

                    <a>{{ product.description }}</a>

                    <template v-if="product.variants!=null&&product.variants.length>0">
                        <h5 class="price"> {{getMinPrice(product)}} </h5>
                    </template>
                </div>
            </div>
        </template>
    </div>
</template>

<script setup>
import pinia from "@/stores"
import useProductList from "@/stores/useProductList"
import { onMounted } from "vue"
import { useRoute } from "vue-router";

const ProductList = useProductList(pinia)
const route = useRoute();

onMounted(async () => {
    if(ProductList.Products.length==0){
        await ProductList.getProductByCategory(route.params.url)
    }
})

function detail(id) {

}

const getMinPrice = function GerPriceText(product) {
    var variants = product.variants
    if (variants.length == 0){
        return "";
    }
    else if (variants.length == 1){
        return "￥" + variants[0].price;
    }

    var prices = variants.map(variant => variant.price);
    var minPrice = Math.min(...prices)

    return "最低￥" + minPrice + "起";
}
</script>

<style scoped> 
.container .product{
    width: 100%;
}

.media-img{
    margin: 20px;
    max-height: 200px;
    max-width: 200px;
    border-radius: 6px;
    margin-bottom: 10px;

    transition: transform .2s;
    flex: 1;
}

a:hover{
    color:purple;
    text-decoration: underline;
}

.media-img:hover {
    transform: scale(1.1);
}

.product{
    width: 200px;
    text-align: center;
    display: flex;
}

.media-body{
    text-align: left;
    flex: 1;
    margin-left: 20px;
}

.price{
    color: green;
}
</style>