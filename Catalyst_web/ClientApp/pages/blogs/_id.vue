<template>
  <div>
    <NavOne />
    <PageHeader title="Blog Details" />
    <BlogDetails />
    <Footer />
  </div>
</template>

<script>
  import PageHeader from "../../components/PageHeader";
  import NavOne from "../../components/NavOne";
  import Footer from "../../components/Footer";
  import BlogDetails from "../../components/BlogDetails";
  export default {
    components: {BlogDetails, Footer, NavOne, PageHeader},
    head(){
      return {
        title: "CA | Blog Details"
      }
    }
  }
</script>
