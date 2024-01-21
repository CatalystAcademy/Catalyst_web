<template>
  <section class="course-one course-page">
    <div class="container">
      <div class="row" v-if="courses.length">
        <div class="col-lg-4" v-for="course in courses" :key="course.id">
          <div class="course-one__single">
            <div class="course-one__image">
              <img src="/assets/images/course-1-1.jpg" alt="">
              <i class="far fa-heart"></i><!-- /.far fa-heart -->
            </div><!-- /.course-one__image -->
            <div class="course-one__content">
              <a href="#" class="course-one__category">development</a><!-- /.course-one__category -->
              <div class="course-one__admin">
                <img src="/assets/images/team-1-1.jpg" alt="">
                by <nuxt-link to="/teacher-details">Lou Guerrero</nuxt-link>
              </div><!-- /.course-one__admin -->
              <h2 class="course-one__title"><nuxt-link to="/course-details">{{course.title}}</nuxt-link></h2>
              <!-- /.course-one__title -->
              <div class="course-one__stars">
                <span class="course-one__stars-wrap">
                  <i class="fa fa-star"></i>
                  <i class="fa fa-star"></i>
                  <i class="fa fa-star"></i>
                  <i class="fa fa-star"></i>
                  <i class="fa fa-star"></i>
                </span><!-- /.course-one__stars-wrap -->
                <span class="course-one__count">4.8</span><!-- /.course-one__count -->
                <span class="course-one__stars-count">250</span><!-- /.course-one__stars-count -->
              </div><!-- /.course-one__stars -->
              <div class="course-one__meta">
                <nuxt-link to="/course-details"><i class="far fa-clock"></i> 10 Hours</nuxt-link>
                <nuxt-link to="/course-details"><i class="far fa-folder-open"></i> 6 Lectures</nuxt-link>
                <nuxt-link to="/course-details">$18</nuxt-link>
              </div><!-- /.course-one__meta -->
              <nuxt-link :to="`courseDetails/${course.id}`" class="course-one__link">
                See Preview
              </nuxt-link>
            </div><!-- /.course-one__content -->
          </div><!-- /.course-one__single -->
        </div><!-- /.col-lg-4 -->

      </div><!-- /.row -->
      <div class="post-pagination">
        <a href="#"><i class="fa fa-angle-double-left"></i><!-- /.fa fa-angle-double-left --></a>
        <a class="active" href="#">1</a>
        <a href="#">2</a>
        <a href="#">3</a>
        <a href="#">4</a>
        <a href="#"><i class="fa fa-angle-double-right"></i><!-- /.fa fa-angle-double-left --></a>
      </div><!-- /.post-pagination -->

    </div><!-- /.container -->

  </section>
</template>


<script>
  import https from 'https';

  export default {
    name: 'Course',
    data() {
      return {
        courses: [],
        loading: true,
        error: false,
        welcomeMessage: '',
      };
    },
    async fetch() { // Use fetch for component-level data fetching
      try {
        const response = await this.$axios.get('/api/Courses');
        this.courses = response.data;

        const welcomeMessageResponse = await this.$axios.get('/api/Courses/GetWelcomeMessage');
        this.welcomeMessage = welcomeMessageResponse.data.message; // Extract message from response

        this.loading = false;
      } catch (error) {
        console.error('Error fetching courses or welcome message:', error);
        this.error = true;
        this.loading = false;
      }
    },
    created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  };
</script>




<!--<script>
  import https from 'https';
  export default {
    name: 'Course',
    async asyncData({ $axios }) {
      $axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      try {
        const welcomeMessageResponse = await $axios.get('https://localhost:7226/api/Courses/GetWelcomeMessage');
        return {
          welcomeMessage: welcomeMessageResponse.data.message
        };
        console.log(welcomeMessage);
        console.log(welcomeMessageResponse.data.message);
      } catch (error) {
        console.error('Error fetching welcome message:', error);
        return { message: '' }; // Handle errors gracefully
      }
    },
  };
</script>-->

<style scoped>

</style>
