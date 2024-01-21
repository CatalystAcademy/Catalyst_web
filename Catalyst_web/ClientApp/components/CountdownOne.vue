<template>
  <section class="countdown-one">
    <div class="container">
        <div class="row">
            <div class="col-lg-6">
                <div class="countdown-one__content">
                    <h2 class="countdown-one__title">Register now </h2><!-- /.countdown-one__title -->
                    <p class="countdown-one__tag-line">get premium online courses for free!</p>
                    <!-- /.countdown-one__tag-line -->
                    <p class="countdown-one__text">Lorem ipsum gravida nibh vel velit auctor aliquetnean sollicitudin,
                        lorem
                        quis bibendum auci elit consequat is simply free text available in the psutis sem nibh id eis
                        sed
                        odio sit amet.</p><!-- /.countdown-one__text -->
                    <ul class="countdown-one__list list-unstyled">
                        <!-- content loading via js -->
                    </ul><!-- /.coundown-one__list -->
                </div><!-- /.countdown-one__content -->
            </div><!-- /.col-lg-6 -->
            <div class="col-lg-6">
                <div class="become-teacher__form">
                    <div class="become-teacher__form-top">
                        <h2 class="become-teacher__form-title">
                            Get free courses
                        </h2><!-- /.become-teacher__form-title -->
                    </div><!-- /.become-teacher__top -->
                    <form @submit.prevent="register" action="/assets/inc/sendemail.php" class="become-teacher__form-content contact-form-validated">
                      <input v-model="registrationData.name" type="text" placeholder="Your Name" name="name">
                      <input v-model="registrationData.email" type="text" placeholder="Email Address" name="email">
                      <select class="custom-select" v-model="registrationData.courseId">
                        <option v-for="course in courses" :key="course.id" :value="course.id">
                          {{ course.title }}
                        </option>
                      </select>
                      <input v-model="registrationData.phoneNumber" type="text" placeholder="Phone Number" name="phone">
                      <input v-model="registrationData.message" type="text" placeholder="Comment" name="message">
                      <button type="submit" class="thm-btn become-teacher__form-btn">Apply For It</button>
                    </form><!-- /.become-teacher__form-content -->
                    <div class="result text-center"></div><!-- /.result -->
                </div><!-- /.become-teacher__form -->
            </div><!-- /.col-lg-6 -->
        </div><!-- /.row -->
    </div><!-- /.container -->
</section>
</template>

<script>
  import https from 'https';
  export default {
    name: "CountdownOne",
    data() {
      return {
        courses: [],
        error: false,
      }
    },
    async fetch() { // Use fetch for component-level data fetching
      try {
        const response = await this.$axios.get('/api/Courses');
        this.courses = response.data;
      }
      catch (error) {
        console.error('Error fetching courses or welcome message:', error);
        this.error = true;
      }
    },
    setup() {
      return {
        registrationData: { name: '', email: '', courseId: '', phoneNumber: '', message: '' },
      };
    },
    methods: {
      async register() {
        try {
          await this.$axios.post('/api/Courses/Register', this.registrationData);
          // Show success message
        } catch (error) {
          // Handle error and display message
        }
      },
    },
    created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  }
</script>

<style scoped>

</style>
