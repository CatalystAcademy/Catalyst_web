<template>
  <div>
    <AdminNav />
  </div>
</template>
<script>
  import AdminNav from "../../components/AdminNav";
  export default {
    middleware: 'auth',
    components: {
      AdminNav
    },
    head(){
      return{
        title: "Admin | Index"
      }
    }
  }
</script>
