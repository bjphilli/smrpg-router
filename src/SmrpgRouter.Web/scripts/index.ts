import Vue from "vue";
import AppBody from "./appbody.vue";
import TopNav from "./topnav.vue";

let vm = new Vue({
    el: "#app",
    template: `
    <div>
        <top-nav></top-nav/>
        <app-body
            name="Blake"
            initialEnthusiasm=3>
        </app-body>
    </div>
    `,
    data: {
        name: "World"
    },
    components: {
        AppBody,
        TopNav
    }
});
