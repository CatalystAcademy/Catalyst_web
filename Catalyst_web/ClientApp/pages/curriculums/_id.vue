<template>
  <div>
    <NavOne />
    <PageHeader title="Curriculum Details" />
    <CurriculumDetails />
    <Footer />
  </div>
</template>

<script>
  import PageHeader from "../../components/PageHeader";
  import NavOne from "../../components/NavOne";
  import Footer from "../../components/Footer";
  import CurriculumDetails from "../../components/CurriculumDetails";
  export default {
    components: { CurriculumDetails, Footer, NavOne, PageHeader },
    head(){
      return {
        title: "Kipso | Curriculum Details"
      }
    }
  }
</script>
