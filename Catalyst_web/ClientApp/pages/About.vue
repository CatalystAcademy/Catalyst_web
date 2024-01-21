<template>
  <div>
    <NavOne />
    <PageHeader title="About" />
    <AboutOne />
    <TeamOne />
    <VideoOne />
    <ClientsLogoOne />
    <div class="border-bottom"></div>
    <Testimonial />
    <CallToActionOne />
    <Footer />
  </div>

</template>

<script>
  export default {
    name: 'AboutPage'
  }
</script>

<!--<script>
  import NavOne from "../components/NavOne";
  import PageHeader from "../components/PageHeader";
  import Footer from "../components/Footer";
  import AboutOne from "../components/AboutOne";
  import TeamOne from "../components/TeamOne";
  import VideoOne from "../components/VideoOne";
  import ClientsLogoOne from "../components/ClientsLogoOne";
  import Testimonial from "../components/Testimonial";
  import CallToActionOne from "../components/CallToActionOne";
  export default {
    components: {
      CallToActionOne,
      Testimonial,
      ClientsLogoOne,
      VideoOne,
      TeamOne,
      AboutOne,
      Footer,
      PageHeader,
      NavOne
    },
    head(){
      return {
        title: "Kipso | About Us"
      }
    }
  }
</script>
-->
