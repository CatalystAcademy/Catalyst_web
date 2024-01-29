<template>
  <div>
    <NavOne />
    <PageHeader title="Blogs" />
    <BlogHome />
    <BlogCarousel />
    <Footer />
  </div>
</template>
<script>import PageHeader from "../components/PageHeader";
  import NavOne from "../components/NavOne";
  import Footer from "../components/Footer";
  import BlogHome from "../components/BlogHome";
  import BlogCarousel from "../components/BlogCarousel";
  export default {
    components: { Footer, NavOne, PageHeader, BlogHome, BlogCarousel },
    head(){
      return {
        title: "CA | Blogs"
      }
    }
  }</script>
