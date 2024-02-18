<template>
  <div>
    <NavOne />
    <PageHeader title="Blogs" />
    <BlogHome />
    <Footer />
  </div>
</template>
<script>import PageHeader from "../components/PageHeader";
  import NavOne from "../components/NavOne";
  import Footer from "../components/Footer";
  import BlogHome from "../components/BlogHome";
  export default {
    components: { Footer, NavOne, PageHeader, BlogHome },
    head(){
      return {
        title: "CA | Blogs"
      }
    }
  }</script>
