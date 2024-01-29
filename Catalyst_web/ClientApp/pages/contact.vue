<template>
  <div>
    <NavOne />
    <PageHeader title="Contact" />
    <Contact />
    <Footer />
  </div>
</template>
<script>
  import PageHeader from "../components/PageHeader";
  import NavOne from "../components/NavOne";
  import Footer from "../components/Footer";
  import Contact from "../components/Contact";
  export default {
    components: {Contact, Footer, NavOne, PageHeader},
    head(){
      return {
        title: "Contact"
      }
    }
  }
</script>
