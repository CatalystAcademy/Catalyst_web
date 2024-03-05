<template>
  <div>
    <NavOne />
    <PageHeader title="Instructors" />
    <Teachers />
    <Footer />
  </div>
</template>
<script>
  import PageHeader from "../components/PageHeader";
  import NavOne from "../components/NavOne";
  import Footer from "../components/Footer";
  import Teachers from "../components/Teachers";
  export default {
    components: {Teachers, Footer, NavOne, PageHeader},
    head(){
      return {
        title: "CA | Instructors"
      }
    }
  }
</script>
