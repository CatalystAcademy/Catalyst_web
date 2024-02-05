<template>
  <div>
    <NavOne />
    <BannerOne />
    <AboutTwo />
    <CourseOne />
    <CourseTwo />
    <VideoTwo />
    <!--    <CountdownOne />
      <CourseCategory />
      <CallToActionThree />-->
    <Testimonial />
    <ClientsLogoTwo />
    <BlogCarousel />
    <CallToActionFour />
    <Subscribe />
    <Footer />
  </div>
</template>


<script>
  export default {
    name: 'IndexPage',
    mounted() {
      const script = document.createElement('script');
      script.async = true;
      script.src = 'https://embed.tawk.to/657937ed07843602b8018a48/1hhgo4u1r';
      script.charset = 'UTF-8';
      script.setAttribute('crossorigin', '*');
      document.head.appendChild(script);

/*      this.$nextTick(() => {
        // Access Tawk_API here, if needed
        console.log(Tawk_API); // Example usage
      });*/
    },
  }
</script>

