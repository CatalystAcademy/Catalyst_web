<template>
  <div>
    <NavOne />
    <PageHeader title="News" />
    <News />
    <Footer />
  </div>
</template>
<script>
  import PageHeader from "../components/PageHeader";
  import NavOne from "../components/NavOne";
  import Footer from "../components/Footer";
  import News from "../components/News";
  export default {
    components: {Footer, NavOne, PageHeader, News},
    head(){
      return {
        title: "Kipso | News"
      }
    }
  }
</script>
