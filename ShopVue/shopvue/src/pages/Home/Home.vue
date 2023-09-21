<template>  
    <img alt="Vue logo" src="@/assets/logo.png">
    <div class="commont-layout">
        <el-container>
            <el-header>

            </el-header>

            <el-main>
                <Nav />
                <router-view>

                </router-view>
            </el-main>
        </el-container>
    </div>
</template>

<script setup>
import Nav from "@/components/Nav.vue"
</script>

<style> 

</style>