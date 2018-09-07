<!-- src/components/topnav.vue -->

<template>
<div class="menu">
    Inside Bottom nav!!!!!!!!
</div>
</template>

<script>
import Vue from 'vue';

export default Vue.extend({
    props: ["name", "initialEnthusiasm"],
    data() {
    },
    methods: {
    },
    computed: {
    },
    components: {
    }
});
</script>

<style>
.menu {
    width: 100%;
    background-color: rgb(14, 201, 208);
    font-size: 24px;
    text-align: center;
    color:dimgrey;
    height: 10%;
}
</style>
