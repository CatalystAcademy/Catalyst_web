<template>
  <div>
    <NavOne />
    <PageHeader title="Course Details" />
    <CourseDetails />
    <Footer />
  </div>
</template>

<script>
  import PageHeader from "../../components/PageHeader";
  import NavOne from "../../components/NavOne";
  import Footer from "../../components/Footer";
  import CourseDetails from "../../components/CourseDetails";
  export default {
    components: { CourseDetails, Footer, NavOne, PageHeader },
    async asyncData({ params }) {
      const courseId = params.id;
      console.log(courseId)
      // Fetch data based on courseId...
      return { courseId };
    },
    head(){
      return {
        title: "Kipso | Course Details"
      }
    }
  }
</script>
