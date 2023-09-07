import axios from "axios";
import { defineStore} from "pinia";

const base_url = "http://localhost:5104";
const useCategory = defineStore("Category", {
    state: () => ({
        Categories: []
    }),
    getters: {

    },
    actions: {
        async getCategories() {
            axios.get(base_url+"/api/Category/GetCategories").then(res => {
                this.Categories = res.data.data
            })
        }
    }
});

export default useCategory;