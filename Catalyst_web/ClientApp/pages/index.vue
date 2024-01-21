<template>
  <div>
    <NavOne />
    <BannerOne />
    <AboutTwo />
    <CourseOne />
    <VideoTwo />
    <CountdownOne />
    <CourseCategory />
    <CallToActionThree />
    <Testimonial />
    <ClientsLogoTwo />
    <BlogCarousel />
    <CallToActionFour />
    <Subscribe />
    <Footer />
<!--    <ul v-if="courses">
      <li v-for="course in courses" :key="course.Id">
        <p>{{ course.title }}</p>
      </li>
    </ul>-->
  </div>
</template>




<script>
  import https from 'https';
  export default {
    name: 'IndexPage',
    async asyncData({ $axios }) { // Inject $axios directly gt
      $axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      try {
        const response = await $axios.get('https://localhost:7226/api/Courses'); // Use relative path
        return { courses: response.data };
      } catch (error) {
        console.error('Error fetching courses:', error);
        return { courses: [] }; // Graceful error handling
      }
    },
  }
</script>
