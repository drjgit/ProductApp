import axios from "axios";
import { defineStore } from "pinia";

const base_url = 'http://localhost:5104';
const useProductList = defineStore("productList", {
    state: () => ({
        Products:[],
        ProductType:[]
    }),
    getters: {

    },
    actions: {
        async getAllProduct() {
            await axios.get(base_url+"/api/Product/GetProductList").then(res => {
                this.Products = res.data.data
                console.log(this.Products)
            })
        }
    }
});

export default useProductList;