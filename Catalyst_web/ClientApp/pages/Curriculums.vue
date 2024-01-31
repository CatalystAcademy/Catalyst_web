<template>
  <div>
    <NavOne />
    <PageHeader title="Curriculums" />
    <Curriculum />
    <Footer />
  </div>
</template>
<script>
  import PageHeader from "../components/PageHeader";
  import NavOne from "../components/NavOne";
  import Footer from "../components/Footer";
  import Curriculum from "../components/Curriculum";
  export default {
    components: { Curriculum, Footer, NavOne, PageHeader},
    head(){
      return {
        title: "CA | Curriculums"
      }
    }
  }
</script>
